
namespace Wadjet.WIN
{
    public static class Consts
    {
        public const ushort IMAGE_DOS_SIGNATURE = 0x5A4D;  // MZ
        public const uint IMAGE_NT_SIGNATURE = 0x00004550; // PE00

        public const ushort IMAGE_FILE_MACHINE_I386 = 0x014C;  // Intel 386
        public const ushort IMAGE_FILE_MACHINE_IA64 = 0x0200;  // Intel 64
        public const ushort IMAGE_FILE_MACHINE_AMD64 = 0x8664; // AMD64

        public const ushort IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10B; // PE32
        public const ushort IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20B; // PE32+

        public const ushort IMAGE_FILE_DLL = 0x2000;
    }
}
