using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 34832)]
[MangledName("struct.lzham::huffman_work_tables")]
[DemangledName("lzham::huffman_work_tables")]
public partial struct lzham_huffman_work_tables
{
	[FieldOffset(0)]
	public InlineArray2049_lzham_sym_freq syms0;

	[FieldOffset(16392)]
	public InlineArray2049_lzham_sym_freq syms1;

	[FieldOffset(32784)]
	public InlineArray1024_Int16 queue;
}
