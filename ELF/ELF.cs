using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Wadjet.ELF
{
    public class ELF
    {
        public byte[] Magic { get; set; }
        public Class Class { get; set; }
        public Endianess Endian { get; set; }
        public int Version { get; set; }
        public int OSABI { get; set; }

        public static ELF ReadIdentificator(string fileName)
        {
            ELF elf = new ELF();
            using (var reader = new BinaryReader(File.OpenRead(fileName)))
            {
                elf.Magic = reader.ReadBytes(4);

                var classByte = reader.ReadByte();
                switch (classByte)
                {
                    case 1:
                        elf.Class = Class.Bit32;
                        break;
                    case 2:
                        elf.Class = Class.Bit64;
                        break;
                    default:
                        throw new ArgumentException(string.Format(
                            "Given ELF file is of unknown class {0}.",
                            classByte
                        ));
                }
                var endianessByte = reader.ReadByte();
                switch (endianessByte)
                {
                    case 1:
                        elf.Endian = Endianess.LittleEndian;
                        break;
                    case 2:
                        elf.Endian = Endianess.BigEndian;
                        break;
                    default:
                        throw new ArgumentException(string.Format(
                            "Given ELF file uses unknown endianess {0}.",
                            endianessByte
                        ));
                }
                reader.ReadBytes(10); // padding bytes of section e_ident
                elf.Version = reader.ReadByte();
                elf.OSABI = reader.ReadByte();

            }
            return elf;
        }
    }
}
