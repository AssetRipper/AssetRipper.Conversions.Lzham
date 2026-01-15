using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_compress_init@lzham@@YAPEAXPEBUlzham_compress_params@@@Z")]
[DemangledName("void * __cdecl lzham::lzham_lib_compress_init(struct lzham_compress_params const *)")]
internal static partial class lzham_lib_compress_init
{
	private partial struct LocalVariables
	{
		public lzham_lzcompressor_init_params field_0;
	}

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("struct lzham_compress_params const *")] void* pParams)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_lzcompressor_init_params);
		void* ptr;
		unchecked
		{
			if (pParams == null || (long)(uint)((lzham_compress_params*)pParams)->m_struct_size != 48L)
			{
				ptr = null;
			}
			else if ((uint)((lzham_compress_params*)pParams)->m_dict_size_log2 < 15u || (uint)((lzham_compress_params*)pParams)->m_dict_size_log2 > 29u)
			{
				ptr = null;
			}
			else
			{
				init_params_Constructor.Invoke(&localsPointer->field_0);
				if (create_internal_init_params.Invoke(&localsPointer->field_0, pParams) != 3)
				{
					ptr = null;
				}
				else
				{
					void* ptr2 = lzham_new_2zi7i7.Invoke();
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					void* ptr3 = ptr2;
					if (ptr3 == null)
					{
						ptr = null;
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzham_compress_state*)ptr3)->m_params, pParams, 48L, isVolatile: false);
						((lzham_lzham_compress_state*)ptr3)->m_pIn_buf = null;
						((lzham_lzham_compress_state*)ptr3)->m_pIn_buf_size = null;
						((lzham_lzham_compress_state*)ptr3)->m_pOut_buf = null;
						((lzham_lzham_compress_state*)ptr3)->m_pOut_buf_size = null;
						((lzham_lzham_compress_state*)ptr3)->m_status = 0;
						((lzham_lzham_compress_state*)ptr3)->m_comp_data_ofs = 0L;
						((lzham_lzham_compress_state*)ptr3)->m_finished_compression = 0;
						if (localsPointer->field_0.m_max_helper_threads != 0)
						{
							if (!init_g7adhy.Invoke(ptr3, localsPointer->field_0.m_max_helper_threads))
							{
								lzham_delete_w5u5xk.Invoke(ptr3);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								ptr = null;
								goto IL_0209;
							}
							if ((uint)Get_num_threads.Invoke(ptr3) >= (uint)localsPointer->field_0.m_max_helper_threads)
							{
								localsPointer->field_0.m_pTask_pool = ptr3;
							}
							else
							{
								localsPointer->field_0.m_max_helper_threads = 0;
							}
						}
						bool flag = init_7dz6ee.Invoke(&((lzham_lzham_compress_state*)ptr3)->m_compressor, &localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						if (!flag)
						{
							lzham_delete_w5u5xk.Invoke(ptr3);
							if (ExceptionInfo.Current != null)
							{
								return null;
							}
							ptr = null;
						}
						else
						{
							ptr = ptr3;
						}
					}
				}
			}
			goto IL_0209;
		}
		IL_0209:
		void* result = ptr;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
