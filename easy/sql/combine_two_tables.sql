-- 175. Combine Two Tables
Select p.firstName, p.lastName, a.city, a.state
FROM person p
LEFT JOIN address a on p.personId = a.personId