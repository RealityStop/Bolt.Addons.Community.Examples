using Ludiq;
using Bolt;
using UnityEngine;
using UnityEditor;

namespace Lasm.Bolt.Comments
{
    [Descriptor(typeof(CommentUnit))]
    public class CommentUnitDescriptor : UnitDescriptor<CommentUnit>
    {
        public CommentUnitDescriptor(CommentUnit unit) : base(unit)
        {

        }

        public Texture2D icon;

        protected override EditorTexture DefaultIcon()
        {
            if (icon == null)
            {
                icon = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/LifeandStyleMedia/Bolt/Comments/Resources/CommentsIcon_32px.png");
            }

            return EditorTexture.Single(icon);
        }

        protected override EditorTexture DefinedIcon()
        {
            if (icon == null)
            {
                icon = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/LifeandStyleMedia/Bolt/Comments/Resources/CommentsIcon_32px.png");
            }

            return EditorTexture.Single(icon);
        }
    }
}
