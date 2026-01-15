using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 6444624)]
[MangledName("struct.lzham::lzham_compress_state")]
[DemangledName("lzham::lzham_compress_state")]
public partial struct lzham_lzham_compress_state
{
	[FieldOffset(0)]
	public InlineArray8_SByte m_tp;

	[FieldOffset(8)]
	public lzham_lzcompressor m_compressor;

	[FieldOffset(6444512)]
	public int m_dict_size_log2;

	[FieldOffset(6444520)]
	public unsafe void* m_pIn_buf;

	[FieldOffset(6444528)]
	public unsafe void* m_pIn_buf_size;

	[FieldOffset(6444536)]
	public unsafe void* m_pOut_buf;

	[FieldOffset(6444544)]
	public unsafe void* m_pOut_buf_size;

	[FieldOffset(6444552)]
	public long m_comp_data_ofs;

	[FieldOffset(6444560)]
	public sbyte m_finished_compression;

	[FieldOffset(6444568)]
	public lzham_compress_params m_params;

	[FieldOffset(6444616)]
	public int m_status;
}
