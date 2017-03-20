namespace graphics_editor
{
    public interface ISelectable
    {
        bool IsSelected { get; set; }

        void Select();
    }
}