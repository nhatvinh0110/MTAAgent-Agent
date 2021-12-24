using System;
using System.Drawing;

namespace Common.DTO
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>

    public partial class Computer
    {

        private string computerIDField;

        private string computerNameField;

        private string cPUNameField;

        private byte rAMField;

        private string osField;

        private string oSReleaseIdField;

        private bool statusField;

        private string pingField;

        private System.DateTime createAtField;

        private System.DateTime lastUpdateField;

        private int roomIDField;

        private string agentVersionField;

        private string dotNetVersionField;

        private string stateField;

        private Bitmap stateField_s;

        private string roomNameField;

        private int SecondsDiffField;

        public string RoomName
        {
            get
            {
                return this.roomNameField;
            }
            set
            {
                if (value == null)
                {
                    this.roomNameField = Constant.NotAvailable;
                }
                else
                {
                    this.roomNameField = value;
                }
            }
        }

        /// <remarks/>
        public string ComputerID
        {
            get
            {
                return this.computerIDField;
            }
            set
            {
                this.computerIDField = value;
            }
        }

        /// <remarks/>
        public string ComputerName
        {
            get
            {
                return this.computerNameField;
            }
            set
            {
                this.computerNameField = value;
            }
        }

        /// <remarks/>
        public string CPUName
        {
            get
            {
                return this.cPUNameField;
            }
            set
            {
                this.cPUNameField = value;
            }
        }

        /// <remarks/>
        public byte RAM
        {
            get
            {
                return this.rAMField;
            }
            set
            {
                this.rAMField = value;
            }
        }

        /// <remarks/>
        public string OS
        {
            get
            {
                return this.osField;
            }
            set
            {
                this.osField = value;
            }
        }

        /// <remarks/>
        public string OSReleaseId
        {
            get
            {
                return this.oSReleaseIdField;
            }
            set
            {
                this.oSReleaseIdField = value;
            }
        }

        /// <remarks/>
        public bool Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string Ping
        {
            get
            {
                return this.pingField;
            }
            set
            {
                this.pingField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreateAt
        {
            get
            {
                return this.createAtField;
            }
            set
            {
                this.createAtField = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastUpdate
        {
            get
            {
                return this.lastUpdateField;
            }
            set
            {
                this.lastUpdateField = value;
            }
        }

        /// <remarks/>
        public int RoomID
        {
            get
            {
                return this.roomIDField;
            }
            set
            {
                this.roomIDField = value;
            }
        }

        /// <remarks/>
        public string AgentVersion
        {
            get
            {
                return this.agentVersionField;
            }
            set
            {
                this.agentVersionField = value;
            }
        }

        /// <remarks/>
        public string DotNetVersion
        {
            get
            {
                return this.dotNetVersionField;
            }
            set
            {
                this.dotNetVersionField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        public Bitmap S_State
        {
            get
            {
                return this.stateField_s;
            }
            set
            {
                this.stateField_s = value;
            }
        }

        public int SecondsDiff
        {
            get
            {
                return this.SecondsDiffField;
            }
            set
            {
                this.SecondsDiffField = value;
            }
        }

    }


}
