using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4decoder_tables@prefix_coding@lzham@@QEAAAEAV012@AEBV012@@Z")]
[DemangledName("public: class lzham::prefix_coding::decoder_tables & __cdecl lzham::prefix_coding::decoder_tables::operator=(class lzham::prefix_coding::decoder_tables const &)")]
internal static partial class decoder_tables_Assignment
{
	[return: NativeType("class lzham::prefix_coding::decoder_tables &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::prefix_coding::decoder_tables const &")] void* rhs)
	{
		assign_e8jmuj.Invoke(@this, rhs);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return @this;
	}
}
