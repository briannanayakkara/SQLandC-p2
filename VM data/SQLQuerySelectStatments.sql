select * from AdminUser
 select * from SuperUser
  select * from StandedUser

select Country.ID, Country.Country_Name, Country.Continent, Ranks.Ranks, Ranks.Birthrate  from Country
 inner join Ranks on Country.ID = Ranks.ID where Country_Name  = 'Denmark'
