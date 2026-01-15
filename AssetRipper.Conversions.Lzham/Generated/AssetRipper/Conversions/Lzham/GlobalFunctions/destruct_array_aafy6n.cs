using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$destruct_array@Ulzpriced_decision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzpriced_decision@lzcompressor@1@I@Z")]
[DemangledName("void __cdecl lzham::helpers::destruct_array<struct lzham::lzcompressor::lzpriced_decision>(struct lzham::lzcompressor::lzpriced_decision *, unsigned int)")]
[CleanName("destruct_array")]
internal static partial class destruct_array_aafy6n
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(lzham_lzcompressor_lzpriced_decision); ptr != ptr2; ptr = (byte*)ptr + sizeof(lzham_lzcompressor_lzpriced_decision))
			{
			}
		}
	}
}
