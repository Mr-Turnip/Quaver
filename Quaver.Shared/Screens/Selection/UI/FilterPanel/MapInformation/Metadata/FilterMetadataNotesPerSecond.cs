using System.Globalization;
using Quaver.API.Helpers;
using Quaver.Shared.Database.Maps;
using Quaver.Shared.Helpers;
using Quaver.Shared.Modifiers;
using Wobble.Bindables;

namespace Quaver.Shared.Screens.Selection.UI.FilterPanel.MapInformation.Metadata
{
    public class FilterMetadataNotesPerSecond : TextKeyValue
    {
        public FilterMetadataNotesPerSecond() : base("NPS: ", "0", 20, ColorHelper.HexToColor($"#ffe76b"))
        {
            if (MapManager.Selected.Value != null)
                Value.Text = $"{GetNotesPerSecond()}";

            MapManager.Selected.ValueChanged += OnMapChanged;
            ModManager.ModsChanged += OnModsChanged;
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public override void Destroy()
        {
            // ReSharper disable twice DelegateSubtraction
            MapManager.Selected.ValueChanged -= OnMapChanged;
            ModManager.ModsChanged -= OnModsChanged;

            base.Destroy();
        }

        private void OnMapChanged(object sender, BindableValueChangedEventArgs<Map> e)
            => Value.Text = GetNotesPerSecond().ToString();

        private int GetNotesPerSecond()
        {
            if (MapManager.Selected.Value == null)
                return 0;

            return MapManager.Selected.Value.NotesPerSecond;
        }

        private void OnModsChanged(object sender, ModsChangedEventArgs e) => Value.Text = GetNotesPerSecond().ToString();
    }
}