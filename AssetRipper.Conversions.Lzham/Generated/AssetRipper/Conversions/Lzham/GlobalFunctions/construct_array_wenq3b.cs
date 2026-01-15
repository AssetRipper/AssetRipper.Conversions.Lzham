using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct_array@Uoutput_symbol@symbol_codec@lzham@@@helpers@lzham@@YAXPEAUoutput_symbol@symbol_codec@1@I@Z")]
[DemangledName("void __cdecl lzham::helpers::construct_array<struct lzham::symbol_codec::output_symbol>(struct lzham::symbol_codec::output_symbol *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_wenq3b
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(lzham_sym_freq); ptr != ptr2; ptr = (byte*)ptr + sizeof(lzham_sym_freq))
			{
			}
		}
	}
}
