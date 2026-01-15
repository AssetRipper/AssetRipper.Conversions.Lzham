using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?construct@?$scalar_type@E@lzham@@SAXPEAEAEBE@Z")]
[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned char>::construct(unsigned char *, unsigned char const &)")]
[CleanName("construct")]
internal static partial class construct_ceg736
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned char *")] void* p, [NativeType("unsigned char const &")] void* init)
	{
		llvm_memcpy_p0_p0_i64.Invoke(p, init, 1L, isVolatile: false);
	}
}
