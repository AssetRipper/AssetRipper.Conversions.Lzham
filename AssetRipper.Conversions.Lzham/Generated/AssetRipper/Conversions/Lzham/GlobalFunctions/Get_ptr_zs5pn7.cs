using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ptr@search_accelerator@lzham@@QEBAPEBEI@Z")]
[DemangledName("public: unsigned char const * __cdecl lzham::search_accelerator::get_ptr(unsigned int) const")]
[CleanName("Get_ptr")]
internal static partial class Get_ptr_zs5pn7
{
	[return: NativeType("unsigned char const *")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int pos)
	{
		return vector_unsigned_char_Operator_7ma9vz.Invoke(&unchecked((lzham_search_accelerator*)@this)->m_dict, pos);
	}
}
