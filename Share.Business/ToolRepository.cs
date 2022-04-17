using Share1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Business
{
   public class ToolRepository
    {
        public List<Tool> GetAllTools()
        {
            ShareDB context = new ShareDB();
            List <Tool> Tools= context.Tools.ToList();
            return Tools;
        }
        public Tool GetToolById(int id)
        {
            ShareDB context = new ShareDB();
            Tool Tool = context.Tools.Find(id);
            return Tool;
        }
        public void Add(Tool tool)
        {
            ShareDB context = new ShareDB();
            context.Tools.Add(tool);
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            ShareDB context = new ShareDB();
            Tool tool = context.Tools.Find(id);
            context.Tools.Remove(tool);
            context.SaveChanges();

        }
        public void Update(Tool tool)
        {
            ShareDB context = new ShareDB();
            Tool oldtool = context.Tools.Find(tool.id);
            context.Entry(oldtool).CurrentValues.SetValues(tool);
            context.SaveChanges();

        }

    }
}
