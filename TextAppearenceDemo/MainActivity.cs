using Android.App;
using Android.Widget;
using Android.OS;

namespace TextAppearenceDemo
{
    [Activity(Label = "TextAppearenceDemo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnClick;
        TextView tvTarget;
        GridView mGridView;
        MyGridViewAdapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btnClick = FindViewById<Button>(Resource.Id.btnClick);
            tvTarget = FindViewById<TextView>(Resource.Id.tvTarget);
            btnClick.Click += BtnClick_Click;
            tvTarget.Text = "Winffeee is not a noob \n He is a genius";
            mGridView = FindViewById<GridView>(Resource.Id.mGridView);

            var numbers = new string[100];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = i.ToString();
            }

            //adapter = new ArrayAdapter<string>(this, Resource.Layout.item1, numbers);
            adapter = new MyGridViewAdapter(numbers);
            
            mGridView.Adapter = adapter;
            var viewTree = mGridView.ViewTreeObserver;
            viewTree.AddOnGlobalLayoutListener(new LayoutChangeListener(mGridView));
        }

        private void BtnClick_Click(object sender, System.EventArgs e)
        {
        }
    }
}

