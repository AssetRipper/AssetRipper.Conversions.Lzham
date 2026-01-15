using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_huge_match_code_bits@lzham@@YAII@Z")]
[DemangledName("unsigned int __cdecl lzham::get_huge_match_code_bits(unsigned int)")]
internal static partial class Get_huge_match_code_bits
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int len)
	{
		unchecked
		{
			int num = len - 258;
			if ((uint)num < 256u)
			{
				return num;
			}
			if ((uint)num < 1280u)
			{
				return (num - 256) | 0x800;
			}
			if ((uint)num < 5376u)
			{
				return (num - 1280) | 0x6000;
			}
			return (num - 5376) | 0x70000;
		}
	}
}
