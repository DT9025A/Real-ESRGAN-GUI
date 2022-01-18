using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lpgui
{
    class MyDataObject : IDataObject
    {
        private String data;

        public string Data { get => data; set => data = value; }

        public object GetData(string format, bool autoConvert)
        {
            throw new NotImplementedException();
        }

        public object GetData(string format)
        {
            if (DataFormats.FileDrop.Equals(format))
            {
                return new String[] { Data };
            }
            return null;
        }

        public object GetData(Type format)
        {
            throw new NotImplementedException();
        }

        public bool GetDataPresent(string format, bool autoConvert)
        {
            throw new NotImplementedException();
        }

        public bool GetDataPresent(string format)
        {
            if (DataFormats.FileDrop.Equals(format))
            {
                return true;
            }
            return false;
        }

        public bool GetDataPresent(Type format)
        {
            throw new NotImplementedException();
        }

        public string[] GetFormats(bool autoConvert)
        {
            throw new NotImplementedException();
        }

        public string[] GetFormats()
        {
            throw new NotImplementedException();
        }

        public void SetData(string format, bool autoConvert, object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(string format, object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(Type format, object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(object data)
        {
            throw new NotImplementedException();
        }
    }
}
