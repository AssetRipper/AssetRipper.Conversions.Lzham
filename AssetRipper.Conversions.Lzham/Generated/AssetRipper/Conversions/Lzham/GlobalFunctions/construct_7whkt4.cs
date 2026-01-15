using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Uoutput_symbol@symbol_codec@lzham@@U123@@helpers@lzham@@YAPEAUoutput_symbol@symbol_codec@1@PEAU231@AEBU231@@Z")]
[DemangledName("struct lzham::symbol_codec::output_symbol * __cdecl lzham::helpers::construct<struct lzham::symbol_codec::output_symbol, struct lzham::symbol_codec::output_symbol>(struct lzham::symbol_codec::output_symbol *, struct lzham::symbol_codec::output_symbol const &)")]
[CleanName("construct")]
internal static partial class construct_7whkt4
{
	[return: NativeType("struct lzham::symbol_codec::output_symbol *")]
	public unsafe static void* Invoke([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("struct lzham::symbol_codec::output_symbol const &")] void* init)
	{
		llvm_memcpy_p0_p0_i64.Invoke(p, init, 8L, isVolatile: false);
		return p;
	}
}
