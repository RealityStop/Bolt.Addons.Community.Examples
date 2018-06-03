using System;
using Ludiq;
using Bolt;
using UnityEngine;

namespace Lasm.Bolt.Comments
{

    [TypeIcon(typeof(CommentUnit))]
    [UnitTitle("Comment")]
    [UnitShortTitle("")]
    [UnitCategory("Tools/Graphs")]
    [RenamedFrom("Lasm.BoltAddons.Helpers.CommentUnit")]
    public class CommentUnit : Unit
    {
        [Inspectable]
        public Color color;

        [Inspectable]
        [UnitHeaderInspectable]
        [InspectorTextArea()]
        public string comment;

        protected override void Definition()
        {
            isControlRoot = true;
        }
    }
        
}
