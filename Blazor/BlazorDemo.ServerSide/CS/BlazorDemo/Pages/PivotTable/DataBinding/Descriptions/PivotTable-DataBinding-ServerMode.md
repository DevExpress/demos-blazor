The DevExpress Blazor Pivot Table supports our high-performance **Server Mode data source**. This unique data source was specifically designed for large data collections displayed in Blazor Server applications.

Server Mode implements advanced data management algorithms that differ from traditional data binding in two key areas:

* Remote data is loaded in small chunks on demand.
* Data shaping operations are delegated to an underlying ORM service (EF Core or DevExpress XPO).

Depending on data source and component configuration, DevExpress Server Mode can significantly reduce load times, optimize client-side memory consumption, and improve component responsiveness and usability.

Follow the steps below to incorporate this data source into your next DevExpress-powered Blazor project:

1. Add a reference to a data source namespace (`DevExpress.Data.Linq`).
2. Create a data source instance. Set the `KeyExpression` property to the name of entity model key property (`Id` in this demo). Use the `QueryableSource` property to define the queryable data source from the EF Core data context.
3. Assign the data source instance to the Pivot Table `Data` property.
4. In the web page's `Dispose` method, dispose of the data source instance.

Explore this demo to experience the performance benefits of the DevExpress Server Mode data source. The Pivot Table in this module is linked to a dataset with over 1,000,000 rows. Navigate between individual pages or sort/group/filter data and note overall responsiveness.
