using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?construct_array@?$scalar_type@E@lzham@@SAXPEAEI@Z")]
[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned char>::construct_array(unsigned char *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_pnydps
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned char *")] void* p, [NativeType("unsigned int")] int n)
	{
		llvm_memset_p0_i64.Invoke(p, 0, unchecked(1L * (long)(uint)n), isVolatile: false);
	}
}
