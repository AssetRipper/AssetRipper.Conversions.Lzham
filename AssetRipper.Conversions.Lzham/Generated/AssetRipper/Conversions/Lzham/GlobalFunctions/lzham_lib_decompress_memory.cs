using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_decompress_memory@lzham@@YA?AW4lzham_decompress_status_t@@PEBUlzham_decompress_params@@PEAEPEA_KPEBE_KPEAI@Z")]
[DemangledName("enum lzham_decompress_status_t __cdecl lzham::lzham_lib_decompress_memory(struct lzham_decompress_params const *, unsigned char *, unsigned __int64 *, unsigned char const *, unsigned __int64, unsigned int *)")]
internal static partial class lzham_lib_decompress_memory
{
	private partial struct LocalVariables
	{
		public long field_0;

		public lzham_decompress_params field_1;
	}

	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int Invoke([NativeType("struct lzham_decompress_params const *")] void* pParams, [NativeType("unsigned char *")] void* pDst_buf, [NativeType("unsigned __int64 *")] void* pDst_len, [NativeType("unsigned char const *")] void* pSrc_buf, [NativeType("unsigned __int64")] long src_len, [NativeType("unsigned int *")] void* pAdler32)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = default(lzham_decompress_params);
		localsPointer->field_0 = src_len;
		int num;
		if (pParams == null)
		{
			num = 15;
		}
		else
		{
			llvm_memcpy_p0_p0_i64.Invoke(&localsPointer->field_1, pParams, 40L, isVolatile: false);
			localsPointer->field_1.m_decompress_flags |= 1;
			void* ptr = lzham_lib_decompress_init.Invoke(&localsPointer->field_1);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			void* ptr2 = ptr;
			if (ptr2 == null)
			{
				num = 4;
			}
			else
			{
				int num2 = lzham_lib_decompress.Invoke(ptr2, pSrc_buf, &localsPointer->field_0, pDst_buf, pDst_len, 1);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				int num3 = num2;
				int num4 = lzham_lib_decompress_deinit.Invoke(ptr2);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				int num5 = num4;
				if (pAdler32 != null)
				{
					*unchecked((int*)pAdler32) = num5;
				}
				num = num3;
			}
		}
		int result = num;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
