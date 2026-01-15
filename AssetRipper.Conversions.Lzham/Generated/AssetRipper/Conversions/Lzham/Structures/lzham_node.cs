using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.lzham::node")]
[DemangledName("lzham::node")]
public partial struct lzham_node
{
	[FieldOffset(0)]
	public int m_left;

	[FieldOffset(4)]
	public int m_right;
}
