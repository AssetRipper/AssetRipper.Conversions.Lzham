using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Ulzdecision@lzcompressor@lzham@@U123@@helpers@lzham@@YAPEAUlzdecision@lzcompressor@1@PEAU231@AEBU231@@Z")]
[DemangledName("struct lzham::lzcompressor::lzdecision * __cdecl lzham::helpers::construct<struct lzham::lzcompressor::lzdecision, struct lzham::lzcompressor::lzdecision>(struct lzham::lzcompressor::lzdecision *, struct lzham::lzcompressor::lzdecision const &)")]
[CleanName("construct")]
internal static partial class construct_uegpcc
{
	[return: NativeType("struct lzham::lzcompressor::lzdecision *")]
	public unsafe static void* Invoke([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* init)
	{
		llvm_memcpy_p0_p0_i64.Invoke(p, init, 12L, isVolatile: false);
		return p;
	}
}
