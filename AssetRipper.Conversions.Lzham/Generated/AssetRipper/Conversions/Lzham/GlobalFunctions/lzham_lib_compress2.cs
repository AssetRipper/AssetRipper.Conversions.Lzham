using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_compress2@lzham@@YA?AW4lzham_compress_status_t@@PEAXPEBEPEA_KPEAE2W4lzham_flush_t@@@Z")]
[DemangledName("enum lzham_compress_status_t __cdecl lzham::lzham_lib_compress2(void *, unsigned char const *, unsigned __int64 *, unsigned char *, unsigned __int64 *, enum lzham_flush_t)")]
internal static partial class lzham_lib_compress2
{
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int Invoke([NativeType("void *")] void* p, [NativeType("unsigned char const *")] void* pIn_buf, [NativeType("unsigned __int64 *")] void* pIn_buf_size, [NativeType("unsigned char *")] void* pOut_buf, [NativeType("unsigned __int64 *")] void* pOut_buf_size, [NativeType("enum lzham_flush_t")] int flush_type)
	{
		void* ptr = pOut_buf;
		unchecked
		{
			if (p == null || ((lzham_lzham_compress_state*)p)->m_params.m_dict_size_log2 == 0 || ((lzham_lzham_compress_state*)p)->m_status >= 3 || pIn_buf_size == null || pOut_buf_size == null)
			{
				return 6;
			}
			if (*(long*)pIn_buf_size != 0L && pIn_buf == null)
			{
				return 6;
			}
			if (*(long*)pOut_buf_size == 0L || ptr == null)
			{
				return 6;
			}
			void* ptr2 = Get_compressed_data.Invoke(&((lzham_lzham_compress_state*)p)->m_compressor);
			long num = 0L;
			if ((ulong)((lzham_lzham_compress_state*)p)->m_comp_data_ofs < (ulong)(uint)size_s5xcpk.Invoke(ptr2))
			{
				long num2 = (((ulong)((uint)size_s5xcpk.Invoke(ptr2) - ((lzham_lzham_compress_state*)p)->m_comp_data_ofs) >= (ulong)(*(long*)pOut_buf_size)) ? (*(long*)pOut_buf_size) : ((uint)size_s5xcpk.Invoke(ptr2) - ((lzham_lzham_compress_state*)p)->m_comp_data_ofs));
				llvm_memcpy_p0_p0_i64.Invoke(ptr, (byte*)Get_ptr_cpjzjc.Invoke(ptr2) + ((lzham_lzham_compress_state*)p)->m_comp_data_ofs, num2, isVolatile: false);
				((lzham_lzham_compress_state*)p)->m_comp_data_ofs += num2;
				if (((((ulong)((lzham_lzham_compress_state*)p)->m_comp_data_ofs >= (ulong)(uint)size_s5xcpk.Invoke(ptr2)) ? 1u : 0u) & 1u) != 1)
				{
					*(long*)pIn_buf_size = 0L;
					*(long*)pOut_buf_size = num2;
					((lzham_lzham_compress_state*)p)->m_status = 2;
					return ((lzham_lzham_compress_state*)p)->m_status;
				}
				ptr = (byte*)ptr + num2;
				*(long*)pOut_buf_size -= num2;
				num += num2;
			}
			try_resize_m9x9dy.Invoke(ptr2, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			((lzham_lzham_compress_state*)p)->m_comp_data_ofs = 0L;
			if ((((lzham_lzham_compress_state*)p)->m_finished_compression & 1) == 1)
			{
				if (*(long*)pIn_buf_size != 0L || flush_type != 4)
				{
					((lzham_lzham_compress_state*)p)->m_status = 6;
					return ((lzham_lzham_compress_state*)p)->m_status;
				}
				*(long*)pIn_buf_size = 0L;
				*(long*)pOut_buf_size = num;
				((lzham_lzham_compress_state*)p)->m_status = 3;
				return ((lzham_lzham_compress_state*)p)->m_status;
			}
			long num3 = ((4194304uL >= (ulong)(*(long*)pIn_buf_size)) ? (*(long*)pIn_buf_size) : 4194304L);
			sbyte b = ((num3 == *(long*)pIn_buf_size) ? ((sbyte)1) : ((sbyte)0));
			if (num3 != 0L)
			{
				bool flag = put_bytes.Invoke(&((lzham_lzham_compress_state*)p)->m_compressor, pIn_buf, (int)num3);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				if (!flag)
				{
					*(long*)pIn_buf_size = 0L;
					*(long*)pOut_buf_size = num;
					((lzham_lzham_compress_state*)p)->m_status = 4;
					return ((lzham_lzham_compress_state*)p)->m_status;
				}
			}
			if ((b & 1) == 1)
			{
				switch (flush_type)
				{
				case 2:
				case 3:
				case 10:
				{
					bool flag3 = flush_z9myat.Invoke(&((lzham_lzham_compress_state*)p)->m_compressor, flush_type);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					if (!flag3)
					{
						*(long*)pIn_buf_size = 0L;
						*(long*)pOut_buf_size = num;
						((lzham_lzham_compress_state*)p)->m_status = 4;
						return ((lzham_lzham_compress_state*)p)->m_status;
					}
					break;
				}
				default:
					if ((((lzham_lzham_compress_state*)p)->m_finished_compression & 1) != 1)
					{
						bool flag2 = put_bytes.Invoke(&((lzham_lzham_compress_state*)p)->m_compressor, null, 0);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						if (!flag2)
						{
							*(long*)pIn_buf_size = 0L;
							*(long*)pOut_buf_size = num;
							((lzham_lzham_compress_state*)p)->m_status = 4;
							return ((lzham_lzham_compress_state*)p)->m_status;
						}
						((lzham_lzham_compress_state*)p)->m_finished_compression = 1;
					}
					break;
				case 0:
					break;
				}
			}
			long num4 = (((ulong)((uint)size_s5xcpk.Invoke(ptr2) - ((lzham_lzham_compress_state*)p)->m_comp_data_ofs) >= (ulong)(*(long*)pOut_buf_size)) ? (*(long*)pOut_buf_size) : ((uint)size_s5xcpk.Invoke(ptr2) - ((lzham_lzham_compress_state*)p)->m_comp_data_ofs));
			if (num4 != 0L)
			{
				llvm_memcpy_p0_p0_i64.Invoke(ptr, (byte*)Get_ptr_cpjzjc.Invoke(ptr2) + ((lzham_lzham_compress_state*)p)->m_comp_data_ofs, num4, isVolatile: false);
				((lzham_lzham_compress_state*)p)->m_comp_data_ofs += num4;
			}
			*(long*)pIn_buf_size = num3;
			*(long*)pOut_buf_size = num + num4;
			sbyte b2 = (((ulong)((lzham_lzham_compress_state*)p)->m_comp_data_ofs >= (ulong)(uint)size_s5xcpk.Invoke(ptr2)) ? ((sbyte)1) : ((sbyte)0));
			if ((b2 & 1) == 1 && flush_type == 4 && (((lzham_lzham_compress_state*)p)->m_finished_compression & 1) == 1)
			{
				((lzham_lzham_compress_state*)p)->m_status = 3;
			}
			else if ((b2 & 1) == 1 && (b & 1) == 1 && flush_type == 0)
			{
				((lzham_lzham_compress_state*)p)->m_status = 1;
			}
			else
			{
				((lzham_lzham_compress_state*)p)->m_status = InstructionHelper.Select((b2 & 1) == 1, 0, 2);
			}
			return ((lzham_lzham_compress_state*)p)->m_status;
		}
	}
}
