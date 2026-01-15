using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct_array@Ulzdecision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzdecision@lzcompressor@1@I@Z")]
[DemangledName("void __cdecl lzham::helpers::construct_array<struct lzham::lzcompressor::lzdecision>(struct lzham::lzcompressor::lzdecision *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_ggqgwp
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(lzham_CLZDecompBase); ptr != ptr2; ptr = (byte*)ptr + sizeof(lzham_CLZDecompBase))
			{
				lzdecision_Constructor_y4m6um.Invoke(ptr);
			}
		}
	}
}
