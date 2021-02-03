# LibraryProject
Library Project is a WinForms app, created in order to help managing library.

I  designed and created database with Entity Framewrok, using the 'code first' approach.

Database is structured using DataAnnotations. 

I used Repository Pattern to seperate data access layer from the UI. Repositories make asynchronous calls to the hosted MSSQL Database.

All repositories implement proper interfaces what allows making Dependency Injection into each Form.

Interfaces were created using the generic programming.

Repositories are used in form of Singletons in Service Provider.

UI is created MDI Forms and user-defined components. 

I created reusable components for client forms.

Communication between the forms is carried out through delegates, on invoked forms' events.

Additional feature is a real-time clock drawn with GDI+
