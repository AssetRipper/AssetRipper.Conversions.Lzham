using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?swap@?$vector@E@lzham@@QEAAXAEAV12@@Z")]
[DemangledName("public: void __cdecl lzham::vector<unsigned char>::swap(class lzham::vector<unsigned char> &)")]
[CleanName("swap")]
internal static partial class swap_ufmqqg
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("class lzham::vector<unsigned char> &")] void* other)
	{
		unchecked
		{
			swap_8p3mrv.Invoke(r: &((lzham_vector*)other)->m_p, l: &((lzham_vector*)@this)->m_p);
			swap_vigik8.Invoke(r: &((lzham_vector*)other)->m_size, l: &((lzham_vector*)@this)->m_size);
			swap_vigik8.Invoke(r: &((lzham_vector*)other)->m_capacity, l: &((lzham_vector*)@this)->m_capacity);
		}
	}
}
