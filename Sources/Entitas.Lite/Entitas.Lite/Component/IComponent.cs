namespace Entitas
{
	/// Implement this interface if you want to create a component which you can add to an entity.
	public interface IComponent
	{
	}

	public interface IUnique
	{
	}

	public interface IEntityIdRef
	{
		int entityId { get; set; }
	}

	public interface IResetable
	{
		void Reset();
	}

	public interface IModifiable
	{
		bool modified { get; set; }
	}
}

