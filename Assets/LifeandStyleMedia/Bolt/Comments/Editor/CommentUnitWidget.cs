using Ludiq;
using Bolt;

namespace Lasm.Bolt.Comments
{
    [RenamedFrom("Lasm.BoltAddons.Helpers.Editor.CommentUnitWidget")]
    [Widget(typeof(CommentUnit))]
    public sealed class CommentUnitWidget : UnitWidget<CommentUnit>
    {

        public CommentUnitWidget(CommentUnit unit) : base(unit)
        {

        }

        protected override NodeColorMix baseColor
        {
            get
            {
                return new NodeColorMix
                {
                    red = unit.color.r,
                    green = unit.color.g,
                    blue = unit.color.b,
                    yellow = 0f,
                    gray = 0f,
                    orange = 0f,
                    teal = 0f
                };
            }
        }


    }
}
