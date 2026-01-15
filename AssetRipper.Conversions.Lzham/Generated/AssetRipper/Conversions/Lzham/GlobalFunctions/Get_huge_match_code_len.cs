using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_huge_match_code_len@lzham@@YAII@Z")]
[DemangledName("unsigned int __cdecl lzham::get_huge_match_code_len(unsigned int)")]
internal static partial class Get_huge_match_code_len
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int len)
	{
		unchecked
		{
			int num = len - 258;
			if ((uint)num < 256u)
			{
				return 9;
			}
			if ((uint)num < 1280u)
			{
				return 12;
			}
			if ((uint)num < 5376u)
			{
				return 15;
			}
			return 19;
		}
	}
}
