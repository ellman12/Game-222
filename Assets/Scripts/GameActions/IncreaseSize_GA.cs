namespace GameActions
{
	public class IncreaseSize_GA : GameAction
	{
		public override void Action()
		{
			transform.localScale *= 2;
		}
	}
}