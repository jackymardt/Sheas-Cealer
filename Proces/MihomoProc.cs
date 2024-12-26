using Sheas_Cealer.Consts;
using Sheas_Core;

namespace Sheas_Cealer.Proces;

internal class MihomoProc : Proc
{
    internal MihomoProc(bool isComihomo) : base(isComihomo ? MainConst.ComihomoPath : MainConst.MihomoPath) { }
}