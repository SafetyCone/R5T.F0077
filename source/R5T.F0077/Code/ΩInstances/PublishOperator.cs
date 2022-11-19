using System;


namespace R5T.F0077
{
	public class PublishOperator : IPublishOperator
	{
		#region Infrastructure

	    public static IPublishOperator Instance { get; } = new PublishOperator();

	    private PublishOperator()
	    {
        }

	    #endregion
	}
}