using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_compress_memory@lzham@@YA?AW4lzham_compress_status_t@@PEBUlzham_compress_params@@PEAEPEA_KPEBE_KPEAI@Z")]
[DemangledName("enum lzham_compress_status_t __cdecl lzham::lzham_lib_compress_memory(struct lzham_compress_params const *, unsigned char *, unsigned __int64 *, unsigned char const *, unsigned __int64, unsigned int *)")]
internal static partial class lzham_lib_compress_memory
{
	private partial struct LocalVariables
	{
		public lzham_lzcompressor_init_params field_0;
	}

	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int Invoke([NativeType("struct lzham_compress_params const *")] void* pParams, [NativeType("unsigned char *")] void* pDst_buf, [NativeType("unsigned __int64 *")] void* pDst_len, [NativeType("unsigned char const *")] void* pSrc_buf, [NativeType("unsigned __int64")] long src_len, [NativeType("unsigned int *")] void* pAdler32)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_lzcompressor_init_params);
		int num;
		unchecked
		{
			if (pParams == null || pDst_len == null)
			{
				num = 6;
			}
			else if (src_len != 0L && pSrc_buf == null)
			{
				num = 6;
			}
			else if ((ulong)src_len > 4294967295uL)
			{
				num = 6;
			}
			else
			{
				init_params_Constructor.Invoke(&localsPointer->field_0);
				int num2 = create_internal_init_params.Invoke(&localsPointer->field_0, pParams);
				if (num2 != 3)
				{
					num = num2;
				}
				else
				{
					void* ptr = null;
					if (localsPointer->field_0.m_max_helper_threads != 0)
					{
						void* ptr2 = lzham_new_9wezva.Invoke();
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						ptr = ptr2;
						if (!init_g7adhy.Invoke(ptr, localsPointer->field_0.m_max_helper_threads))
						{
							num = 4;
							goto IL_032e;
						}
						localsPointer->field_0.m_pTask_pool = ptr;
					}
					void* ptr3 = lzham_new_pkbiun.Invoke();
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					void* ptr4 = ptr3;
					if (ptr4 == null)
					{
						lzham_delete_w9ji3f.Invoke(ptr);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num = 4;
					}
					else
					{
						bool flag = init_7dz6ee.Invoke(ptr4, &localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						if (!flag)
						{
							lzham_delete_w9ji3f.Invoke(ptr);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							lzham_delete_5e8ypf.Invoke(ptr4);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num = 6;
						}
						else
						{
							if (src_len != 0L)
							{
								bool flag2 = put_bytes.Invoke(ptr4, pSrc_buf, (int)src_len);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								if (!flag2)
								{
									*(long*)pDst_len = 0L;
									lzham_delete_w9ji3f.Invoke(ptr);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									lzham_delete_5e8ypf.Invoke(ptr4);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									num = 4;
									goto IL_032e;
								}
							}
							bool flag3 = put_bytes.Invoke(ptr4, null, 0);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							if (!flag3)
							{
								*(long*)pDst_len = 0L;
								lzham_delete_w9ji3f.Invoke(ptr);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								lzham_delete_5e8ypf.Invoke(ptr4);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num = 4;
							}
							else
							{
								void* ptr5 = Get_compressed_data.Invoke(ptr4);
								long num3 = *(long*)pDst_len;
								*(long*)pDst_len = (uint)size_s5xcpk.Invoke(ptr5);
								if (pAdler32 != null)
								{
									*(int*)pAdler32 = Get_src_adler32.Invoke(ptr4);
								}
								if ((ulong)(uint)size_s5xcpk.Invoke(ptr5) > (ulong)num3)
								{
									lzham_delete_w9ji3f.Invoke(ptr);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									lzham_delete_5e8ypf.Invoke(ptr4);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									num = 7;
								}
								else
								{
									llvm_memcpy_p0_p0_i64.Invoke(pDst_buf, Get_ptr_pyhvtd.Invoke(ptr5), (uint)size_s5xcpk.Invoke(ptr5), isVolatile: false);
									lzham_delete_w9ji3f.Invoke(ptr);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									lzham_delete_5e8ypf.Invoke(ptr4);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									num = 3;
								}
							}
						}
					}
				}
			}
			goto IL_032e;
		}
		IL_032e:
		int result = num;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
