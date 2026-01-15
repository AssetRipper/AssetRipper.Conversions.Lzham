using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Ulzpriced_decision@lzcompressor@lzham@@U123@@helpers@lzham@@YAPEAUlzpriced_decision@lzcompressor@1@PEAU231@AEBU231@@Z")]
[DemangledName("struct lzham::lzcompressor::lzpriced_decision * __cdecl lzham::helpers::construct<struct lzham::lzcompressor::lzpriced_decision, struct lzham::lzcompressor::lzpriced_decision>(struct lzham::lzcompressor::lzpriced_decision *, struct lzham::lzcompressor::lzpriced_decision const &)")]
[CleanName("construct")]
internal static partial class construct_itzgbx
{
	[return: NativeType("struct lzham::lzcompressor::lzpriced_decision *")]
	public unsafe static void* Invoke([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("struct lzham::lzcompressor::lzpriced_decision const &")] void* init)
	{
		llvm_memcpy_p0_p0_i64.Invoke(p, init, 24L, isVolatile: false);
		return p;
	}
}
