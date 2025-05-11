using PinguTools.Common;
using Riok.Mapperly.Abstractions;

namespace PinguTools.Models;

[Mapper]
public static partial class ModelMapper
{
    public static partial WorkflowModel ToModel(this ChartMeta source);

    public static partial ChartMeta ToMeta(this WorkflowModel source);
}