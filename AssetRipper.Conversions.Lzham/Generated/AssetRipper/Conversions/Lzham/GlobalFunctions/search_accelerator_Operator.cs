using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??Asearch_accelerator@lzham@@QEBAII@Z")]
[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::operator[](unsigned int) const")]
internal static partial class search_accelerator_Operator
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int pos)
	{
		return unchecked((byte)(*(sbyte*)vector_unsigned_char_Operator_7ma9vz.Invoke(&((lzham_search_accelerator*)@this)->m_dict, pos)));
	}
}
