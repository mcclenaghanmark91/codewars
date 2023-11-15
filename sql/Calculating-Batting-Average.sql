SELECT    player_name, 
          games,
          CAST(ROUND(hits/at_bats::numeric, 3) AS TEXT) AS batting_average
FROM      yankees
WHERE     at_bats >= 100
ORDER BY  batting_average DESC
