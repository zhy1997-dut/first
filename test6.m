clear all
clc
seed=1;
y7out=zeros(100,100);
sign6=6*ones(3,1);
amp_arr=0.7*rand(100,1)+0.3;
t6_arr=4.4*rand(100,1)+0.1;
period_arr=randi([8,40],100,1);
seed_arr=randi([1,1000],100,1);
for i=1:100
    amp7=amp_arr(i,1);
    t6=t6_arr(i,1);
    period=period_arr(i,1);
    seed=seed_arr(i,1);
    sim("test06.slx"); 
    for j=1:100
        if y7(j)<0
            y7(j)=0;
        elseif y7(j)>4
                y7(j)=4;
        end
    end
    y7out(:,i)=y7;
end
k7_t=y7out(:,1:3);
y7_t=y7out(:,1:80);
save k7.mat k7_t;
save y7.mat y7_t;
% save y6.mat y6_t y6_c;
% stairs(tout,y6_t,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")
% 
% y06=[y6_t',sign6];
% fid = fopen('y6.txt','wt');
% [m,n]=size(y06); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y06(i,j)); 
% else 
% fprintf(fid,'%g\t',y06(i,j)); 
% end 
% end 
% end 
% fclose(fid);