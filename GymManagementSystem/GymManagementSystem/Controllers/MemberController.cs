using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementSystem.Repositories;
using GymManagementSystem.Models;

namespace GymManagementSystem.Controllers
{
    /// Acts as the bridge between the View and the MemberRepository.
    /// The View calls the Controller, the Controller calls the Repository,
    /// and the Repository talks to the database.
    public class MemberController
    {
        private MemberRepository memberRepository;

        public MemberController()
        {
            memberRepository = new MemberRepository();
        }

        public List<Member> GetAllMembers()
        {
            return memberRepository.GetAllMembers();
        }

        public Member GetMemberByID(int memberId)
        {
            return memberRepository.GetByID(memberId);
        }

        public List<Member> SearchMembers(string name)
        {
            return memberRepository.SearchMembers(name);
        }

        public int GetTotalMembers()
        {
            return memberRepository.GetTotalMembers();
        }

        public int GetActiveSubscriptionCount()
        {
            return memberRepository.GetActiveSubscriptionCount();
        }

        public void AddMember(Member member)
        {
            memberRepository.AddMember(member);
        }

        public void UpdateMember(Member member)
        {
            memberRepository.UpdateMember(member);
        }

        public void DeactivateMember(int memberId)
        {
            memberRepository.DeactivateMember(memberId);
        }

        public void DeleteMember(int memberId)
        {
            memberRepository.DeleteMember(memberId);
        }
    }
}
