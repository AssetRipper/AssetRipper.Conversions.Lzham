using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_len@dict_match@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::dict_match::get_len(void) const")]
[CleanName("Get_len")]
internal static partial class Get_len_xiv86i
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((ushort)((lzham_dict_match*)@this)->m_len) + 2;
	}
}
