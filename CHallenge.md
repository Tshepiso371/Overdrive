## Why does using PostgreSQL over SQLite matter for a "Produvtion Readiness" mindset?
Because Postgre supports advanced indexing and scaling while SqLite is mostly used for small applications 

## Why should we calculate the "Total Pending Tasks" as derived state rather than saving it in a separate useState variable?
Because storing it causes State inconsistency , the tasks might update but pendingCount might not update


## Explain how include () would be used in EF Core if our tasks had a "Category" relationship, and why forgetting it causes an $N+ 1$ problem
Without Include() EF will query only 1 query for tasks and +1 query per category , which causes $N+1$ problem and with include it can do more quiries which is much faster