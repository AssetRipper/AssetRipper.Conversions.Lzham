using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$swap@I@utils@lzham@@YAXAEAI0@Z")]
[DemangledName("void __cdecl lzham::utils::swap<unsigned int>(unsigned int &, unsigned int &)")]
[CleanName("swap")]
internal static partial class swap_vigik8
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int &")] void* l, [NativeType("unsigned int &")] void* r)
	{
		unchecked
		{
			int num = *(int*)l;
			*(int*)l = *(int*)r;
			*(int*)r = num;
		}
	}
}
