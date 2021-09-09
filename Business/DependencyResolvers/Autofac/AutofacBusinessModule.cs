using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MemberManager>().As<IMemberService>().SingleInstance();
            builder.RegisterType<EfMemberDal>().As<IMemberDal>().SingleInstance();

            builder.RegisterType<GymManager>().As<IGymService>().SingleInstance();
            builder.RegisterType<EfGymDal>().As<IGymDal>().SingleInstance();

            builder.RegisterType<GymTimeManager>().As<IGymTimeService>().SingleInstance();
            builder.RegisterType<EfGymTimeDal>().As<IGymTimeDal>().SingleInstance();

            builder.RegisterType<MembershipInfoManager>().As<IMembershipInfoService>().SingleInstance();
            builder.RegisterType<EfMembershipInfoDal>().As<IMembershipInfoDal>().SingleInstance();

            builder.RegisterType<WorkingHourManager>().As<IWorkingHourService>().SingleInstance();
            builder.RegisterType<EfWorkingHourDal>().As<IWorkingHourDal>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();
        }
    }
}
