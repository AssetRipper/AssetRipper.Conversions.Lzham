using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct_array@Vadaptive_bit_model@lzham@@@helpers@lzham@@YAXPEAVadaptive_bit_model@1@I@Z")]
[DemangledName("void __cdecl lzham::helpers::construct_array<class lzham::adaptive_bit_model>(class lzham::adaptive_bit_model *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_auatq4
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(lzham_adaptive_bit_model); ptr != ptr2; ptr = (byte*)ptr + sizeof(lzham_adaptive_bit_model))
			{
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr);
			}
		}
	}
}
