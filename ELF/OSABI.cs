using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Wadjet.ELF
{
    public class OSABI
    {
        public static OSABI instance = new OSABI();
        public List<ABI> ABIs { get; set; }

        public OSABI()
        {
            ABIs = new List<ABI>();
            ABIs.Add(new ABI(0x00, "System V"));
            ABIs.Add(new ABI(0x01, "HP-UX"));
            ABIs.Add(new ABI(0x02, "NetBSD"));
            ABIs.Add(new ABI(0x03, "Linux"));
            ABIs.Add(new ABI(0x04, "GNU Hurd"));
            ABIs.Add(new ABI(0x06, "Solaris"));
            ABIs.Add(new ABI(0x07, "AIX"));
            ABIs.Add(new ABI(0x08, "IRIX"));
            ABIs.Add(new ABI(0x09, "FreeBSD"));
            ABIs.Add(new ABI(0x0A, "Tru64"));
            ABIs.Add(new ABI(0x0B, "Novell Modesto"));
            ABIs.Add(new ABI(0x0C, "OpenBSD"));
            ABIs.Add(new ABI(0x0D, "OpenVMS"));
            ABIs.Add(new ABI(0x0E, "NonStop Kernel"));
            ABIs.Add(new ABI(0x0F, "AROS"));
            ABIs.Add(new ABI(0x10, "Fenix OS"));
            ABIs.Add(new ABI(0x11, "CloudABI"));
        }

    }

    public class ABI
    {
        public byte Value { get; set; }
        public string Name { get; set; }

        public ABI()
        { }

        public ABI(byte Val, string Name) {
            this.Value = Val;
            this.Name = Name;
        }
    }
}
