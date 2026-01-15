using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@G@lzham@@QEAAAEAGI@Z")]
[DemangledName("public: unsigned short & __cdecl lzham::vector<unsigned short>::operator[](unsigned int)")]
internal static partial class vector_unsigned_short_Operator
{
	[return: NativeType("unsigned short &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)2);
	}
}
