using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct_array@Ulzpriced_decision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzpriced_decision@lzcompressor@1@I@Z")]
[DemangledName("void __cdecl lzham::helpers::construct_array<struct lzham::lzcompressor::lzpriced_decision>(struct lzham::lzcompressor::lzpriced_decision *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_7apt7b
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(lzham_lzcompressor_lzpriced_decision); ptr != ptr2; ptr = (byte*)ptr + sizeof(lzham_lzcompressor_lzpriced_decision))
			{
				lzpriced_decision_Constructor_iyvu5a.Invoke(ptr);
			}
		}
	}
}
