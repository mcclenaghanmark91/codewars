SELECT id, name
FROM departments D
WHERE EXISTS (SELECT department_id FROM sales WHERE D.id = department_id AND price > 98.00)
