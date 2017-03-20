using System.Drawing;

namespace graphics_editor
{
    public interface ISelectable
    {
        void Select(Graphics g, Pen pen);
    }
}