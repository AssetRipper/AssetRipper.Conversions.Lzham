using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("class.lzham::vector")]
[DemangledName("lzham::vector")]
public partial struct lzham_vector
{
	[FieldOffset(0)]
	public unsafe void* m_p;

	[FieldOffset(8)]
	public int m_size;

	[FieldOffset(12)]
	public int m_capacity;
}
