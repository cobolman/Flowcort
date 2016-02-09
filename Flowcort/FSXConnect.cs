using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowcort
{
    class FSXConnect
    {
        const int WM_USER_SIMCONNECT = 0x0402;

        enum EVENTS
        {
            KEY_TOGGLE_PROPELLER_DEICE,
            KEY_PRESSURIZATION_PRESSURE_ALT_INC,
            KEY_PRESSURIZATION_PRESSURE_ALT_DEC,
            KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH,
        };

        enum NOTIFICATION_GROUPS
        {
            GROUP0,
        }

        enum DEFINITIONS
        {
            Struct1,
        }

        enum DATA_REQUESTS
        {
            REQUEST_1,
        }

        // this is how you declare a data structure so that 
        // simconnect knows how to fill it/read it. 
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            // this is how you declare a fixed size string 
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public String title;
            public double latitude;
            public double longitude;
            public double altitude;
        };

        // Class Variables
        public SimConnect simconnect = null;
        public Timer timer1 = new Timer();

        private Form owner { get; set; }
        private String title { get; set; }
        private int altitude { get; set; }
        private double latitude { get; set; }
        private double longitude { get; set; }

        // Event Handlers
        public event EventHandler<AltitudeChangedEventArgs> AltitudeChangedEventHandler;
        public event EventHandler<TitleChangedEventArgs> TitleChangedEventHandler;
        public event EventHandler<LatitudeChangedEventArgs> LatitudeChangedEventHandler;
        public event EventHandler<LongitudeChangedEventArgs> LongitudeChangedEventHandler;
        public event EventHandler<FSXActionEventArgs> FSXActionEventHandler;
        public event EventHandler ConnectionOpenEventHandler;
        public event EventHandler FSXQuitEventHandler;

        // EventArgs
        public class AltitudeChangedEventArgs : EventArgs
        {
            public int altitude { get; set; }
        }

        public class TitleChangedEventArgs : EventArgs
        {
            public String Title { get; set; }
        }

        public class LatitudeChangedEventArgs : EventArgs
        {
            public double Latitude { get; set; }
        }
        public class LongitudeChangedEventArgs : EventArgs
        {
            public double Longitude { get; set; }
        }

        public class FSXActionEventArgs : EventArgs
        {
            public uint Action { get; set; }
        }

        // Events
        public void OnAltitudeChanged(AltitudeChangedEventArgs e)
        {
            EventHandler<AltitudeChangedEventArgs> handler = AltitudeChangedEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void OnTitleChanged(TitleChangedEventArgs e)
        {
            EventHandler<TitleChangedEventArgs> handler = TitleChangedEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }

        }

        public void OnLatitudeChanged(LatitudeChangedEventArgs e)
        {
            EventHandler<LatitudeChangedEventArgs> handler = LatitudeChangedEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }

        }

        public void OnLongitudeChanged(LongitudeChangedEventArgs e)
        {
            EventHandler<LongitudeChangedEventArgs> handler = LongitudeChangedEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }

        }

        public void OnConnectionOpen(EventArgs e)
        {
            EventHandler handler = ConnectionOpenEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void OnFSXQuit(EventArgs e)
        {
            EventHandler handler = FSXQuitEventHandler;
            if (handler != null) handler(this, e);
        }

        public void OnFSXAction(FSXActionEventArgs e)
        {
            EventHandler<FSXActionEventArgs> handler = FSXActionEventHandler;
            if (handler != null) handler(this, e);
        }

        public FSXConnect(Form sender = null)
        {
            owner = sender;
            title = "";
            altitude = 0;
            latitude = 0.0;
            longitude = 0.0;

            timer1.Tick += timer1_Tick;
        }

        public void openConnection()
        {
            if (owner != null)
            {
                if (simconnect == null)
                {
                    try
                    {
                        simconnect = new SimConnect("Managed Client Events", owner.Handle, WM_USER_SIMCONNECT, null, 0);
                        initClientEvent();
                    }
                    catch (COMException ex)
                    {
                        MessageBox.Show("Unable to connect to your Flight Simulator " + ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("Cannot connect to FSX / P3d. Need a form to send notifications to");
        }

        public void closeConnection()
        {
            if (simconnect != null)
            {
                // Dispose serves the same purpose as SimConnect_Close() 
                simconnect.Dispose();
                simconnect = null;
            }
        }

        private void initClientEvent()
        {
            try
            {
                // listen to connect and quit msgs 
                simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(simconnect_OnRecvOpen);
                simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simconnect_OnRecvQuit);

                // listen to exceptions 
                simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(simconnect_OnRecvException);

                // listen to events 
                simconnect.OnRecvEvent += new SimConnect.RecvEventEventHandler(simconnect_OnRecvEvent);

                // subscribe to Flowcort Prior Item, Next Item and Done/Undone Toggle events 
                simconnect.MapClientEventToSimEvent(EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_INC, "PRESSURIZATION_PRESSURE_ALT_INC");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_INC, false);

                simconnect.MapClientEventToSimEvent(EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_DEC, "PRESSURIZATION_PRESSURE_ALT_DEC");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_DEC, false);

                simconnect.MapClientEventToSimEvent(EVENTS.KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH, "PRESSURIZATION_PRESSURE_DUMP_SWITCH");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH, false);

                simconnect.MapClientEventToSimEvent(EVENTS.KEY_TOGGLE_PROPELLER_DEICE, "TOGGLE_PROPELLER_DEICE");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_TOGGLE_PROPELLER_DEICE, false);

                // set the group priority 
                simconnect.SetNotificationGroupPriority(NOTIFICATION_GROUPS.GROUP0, SimConnect.SIMCONNECT_GROUP_PRIORITY_HIGHEST);

                // define a data structure 
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                // IMPORTANT: register it with the simconnect managed wrapper marshaller 
                // if you skip this step, you will only receive a uint in the .dwData field. 
                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);

                // catch a simobject data request 
                simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_OnRecvSimobjectDataBytype);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {

            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.REQUEST_1:
                    Struct1 s1 = (Struct1)data.dwData[0];

                    processTitle(s1.title);
                    processLatitude(s1.latitude);
                    processLongitude(s1.longitude);
                    processAltitude(s1.altitude);
                    break;

                default:
                    // txtbxRemarks.Text += "Unknown request ID: " + data.dwRequestID;
                    break;
            }
        }

        private void processTitle(string p)
        {
            if (p != title)
            {
                TitleChangedEventArgs args = new TitleChangedEventArgs();
                args.Title = p;
                title = p;
                OnTitleChanged(args);
            }
        }

        private void processLatitude(double p)
        {
            if (p != latitude)
            {
                LatitudeChangedEventArgs args = new LatitudeChangedEventArgs();
                args.Latitude = p;
                latitude = p;
                OnLatitudeChanged(args);
            }
        }

        private void processLongitude(double p)
        {
            if (p != longitude)
            {
                LongitudeChangedEventArgs args = new LongitudeChangedEventArgs();
                args.Longitude = p;
                longitude = p;
                OnLongitudeChanged(args);
            }
        }

        private void processAltitude(double alt)
        {
            int a = (int)alt;
            if (a != altitude)
            {
                AltitudeChangedEventArgs args = new AltitudeChangedEventArgs();
                args.altitude = a;
                altitude = a;
                OnAltitudeChanged(args);
            }
        }

        public void pollFSXData(int pollInterval = 1000)
        {
            // interval enabled
            timer1.Interval = pollInterval;
            timer1.Enabled = true;
        }

        public void stopPolling()
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (simconnect != null)
            {
                simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            }
        }

        void simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            OnConnectionOpen(EventArgs.Empty);
        }

        // The case where the user closes FSX / P3d 
        void simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            OnFSXQuit(EventArgs.Empty);
            closeConnection();
        }

        void simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            MessageBox.Show("FSXConnect Exception received: " + data.dwException);
        }

        void simconnect_OnRecvEvent(SimConnect sender, SIMCONNECT_RECV_EVENT recEvent)
        {
            FSXActionEventArgs args = new FSXActionEventArgs();
            args.Action = recEvent.uEventID;
            OnFSXAction(args);
        }

    }

}
