﻿using Project.BusinessLayer.Abstracts;
using Project.DataAccessLayer.Abstracts;
using Project.EntityLayer.Entities.Concretes;

namespace Project.BusinessLayer.Concretes;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public void TAdd(Testimonial entity)
    {
        _testimonialDal.Add(entity);
    }

    public void TDelete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public List<Testimonial> TGetAll()
    {
        return _testimonialDal.GetAll();
    }

    public Testimonial TGetById(int id)
    {
        return _testimonialDal.GetById(id);
    }

    public void TUpdate(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }
}
