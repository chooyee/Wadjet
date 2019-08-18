using System;
using System.IO;

namespace Wadjet.ELF
{
	public static class ELFReader
	{
        public static bool isValidELF(string fileName)
        {
            if (ELFReader.CheckELFType(fileName) == Class.NotELF)
                return false;
            else
                return true;
        }

        public static Class CheckELFType(string fileName)
		{
			var size = new FileInfo(fileName).Length;
			if(size < Consts.MinimalELFSize)
			{
				return Class.NotELF;
			}
			using(var reader = new BinaryReader(File.OpenRead(fileName)))
			{
				var magic = reader.ReadBytes(4);
				for(var i = 0; i < 4; i++)
				{
					if(magic[i] != Magic[i])
					{
						return Class.NotELF;
					}
				}
				var value = reader.ReadByte();
				return value == 1 ? Class.Bit32 : Class.Bit64;
			}
		}
       
		private static readonly byte[] Magic = {
			0x7F,
			0x45,
			0x4C,
			0x46
		}; // 0x7F 'E' 'L' 'F'
        
	}
}