﻿namespace GalaxyExpress.DAL.Entities;

public class UserPromoCode
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;

    public Guid PromoCodeId { get; set; }
    public PromoCode PromoCode { get; set; } = default!;
}