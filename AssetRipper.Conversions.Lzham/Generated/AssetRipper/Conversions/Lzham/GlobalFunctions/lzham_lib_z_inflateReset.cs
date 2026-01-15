using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_inflateReset@lzham@@YAHPEAUlzham_z_stream@@@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_inflateReset(struct lzham_z_stream *)")]
internal static partial class lzham_lib_z_inflateReset
{
	private partial struct LocalVariables
	{
		public lzham_decompress_params field_0;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_decompress_params);
		unchecked
		{
			int num;
			if (pStream == null || ((lzham_z_stream*)pStream)->state == null)
			{
				num = -2;
			}
			else
			{
				void* state = ((lzham_z_stream*)pStream)->state;
				llvm_memcpy_p0_p0_i64.Invoke(source: &((lzham_lzham_decompressor*)state)->m_params, destination: &localsPointer->field_0, length: 40L, isVolatile: false);
				void* ptr = lzham_lib_decompress_reinit.Invoke(state, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num = ((ptr == null) ? (-2) : 0);
			}
			int result = num;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
