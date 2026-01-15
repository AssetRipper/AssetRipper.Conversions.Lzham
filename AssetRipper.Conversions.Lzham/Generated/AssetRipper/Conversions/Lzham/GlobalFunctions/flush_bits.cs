using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?flush_bits@symbol_codec@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::flush_bits(void)")]
internal static partial class flush_bits
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		bool result = put_bits.Invoke(@this, 0, 7);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
